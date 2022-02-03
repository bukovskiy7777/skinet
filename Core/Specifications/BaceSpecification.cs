using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class BaceSpecification<T> : ISpecification<T>
    {

        
        public BaceSpecification(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }

        public BaceSpecification() 
        {
           
        }

        public Expression<Func<T, bool>> Criteria {get; }

        public List<Expression<Func<T, object>>> Includes {get; } = new List<Expression<Func<T, object>>>();

        protected void AddInclude(Expression<Func<T, object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }
    }
}