using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Linq.Expressions;
using DEMO.Entity;

namespace Peercore.IngresLinq
{
    public static class Extensions
    {
        public static IQueryable<TResult> PSelect<TSource, TResult>(this IQueryable<TSource> query, Expression<Func<TSource, TResult>> selector)
        {
            var properties = typeof(TResult).GetProperties().ToArray();
            Expression newExpression = null;
            
            if (selector.Body is MemberInitExpression)
            {
                var initEx = selector.Body as MemberInitExpression;
                //var bindings = initEx.Bindings.Where(b => !updates.Keys.Contains(b.Member.Name)).ToList();
                //var bindUpdates = updates.Select(u => Expression.Bind(properties.Single(p => p.Name == u.Key),Expression.Invoke(u.Value, selector.Parameters.ToArray()))).ToArray();
    
                //newExpression = Expression.MemberInit(initEx.NewExpression, bindings.Concat(bindUpdates));                
            }
            else if (selector.Body is NewExpression)
            {
                var newEx = selector.Body as NewExpression;
                var args = newEx.Arguments.ToArray();
                var members = newEx.Members.ToArray();
                var newArgs = new List<Expression>();
                for (int i = 0; i < members.Length; i++)
                {
                        newArgs.Add(args[i]);
                }
                newExpression = Expression.New(newEx.Constructor, newArgs, members);
            }
            
            return query.Select(Expression.Lambda<Func<TSource, TResult>>(newExpression, selector.Parameters));
        }
    }
}
