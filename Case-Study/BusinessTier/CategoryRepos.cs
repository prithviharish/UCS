using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class CategoryRepos
    {
        public List<workout_category> GetAll()
        {
            try
            {
                using (workEntities objcontext = new workEntities())
                {
                    var query = from obj in objcontext.workout_category
                                select obj;

                    return query.ToList();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public workout_category GetById(int categoryid)
        {
            try
            {
                using (workEntities objcontext = new workEntities())
                {
                    var query = (from obj in objcontext.workout_category
                                 where obj.category_id == categoryid
                                 select obj).FirstOrDefault();

                    return query;
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
     
