using DataAccess_Layer.Interface_DAL;
using DOT;
using Model;
using Model.model;

namespace DataAccess_Layer
{
    public class Data : IData
    {

        private readonly dbcontext _dbcontext;
        public Data(dbcontext dbContext)
        {
            _dbcontext = dbContext;
        }
        public async Task<object> GET()
        {
           
            var result = (from ans in _dbcontext.customer_db
                          join anss in _dbcontext.SELLER_db on
                          ans.CUSTOMER_ID equals anss.SELLER_ID
                          select new View
                          {
                              EMAIL_ID = anss.EMAIL_ID,
                              SELLER_ID = anss.SELLER_ID,
                              GENDER = anss.GENDER,
                              CUSTOMER_NAME = ans.CUSTOMER_NAME,
                              CUSTOMER_ADDRESS = ans.CUSTOMER_ADDRESS,
                              CUSTOMER_AGE = ans.CUSTOMER_AGE,
                              CUSTOMER_ID = ans.CUSTOMER_ID

                          }).ToList();

            return result;
        }
        public async Task<object> POST(View details)
        {
            using (var transaction = _dbcontext.Database.BeginTransaction())
            {
                try
                {
                    var post = new Customer()
                    {
                        CUSTOMER_ID = details.CUSTOMER_ID,
                        CUSTOMER_NAME = details.CUSTOMER_NAME,
                        CUSTOMER_AGE = details.CUSTOMER_AGE,
                        CUSTOMER_ADDRESS = details.CUSTOMER_ADDRESS
                        
                    };
                    _dbcontext.customer_db.Add(post);
                    _dbcontext.SaveChanges();
                    var emp = new Seller()
                    {
                        SELLER_ID = details.SELLER_ID,
                        EMAIL_ID = details.EMAIL_ID,
                        GENDER = details.GENDER,
                        CUSTOMER_ID = post.CUSTOMER_ID,
                    };

                    _dbcontext.SELLER_db.Add(emp);



                    _dbcontext.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {

                    transaction.Rollback();
                }
            }
            return details;
        }
        public async Task<object> PUT(View details)
        {
            using (var transfer = _dbcontext.Database.BeginTransaction())
            {
                try
                {
                    var put = _dbcontext.customer_db.Find(details.CUSTOMER_ID);
                    if (put != null)
                    {
                        put.CUSTOMER_NAME = details.CUSTOMER_NAME;
                        put.CUSTOMER_AGE = details.CUSTOMER_AGE;
                        put.CUSTOMER_ADDRESS = details.CUSTOMER_ADDRESS;
                       
                        _dbcontext.SaveChanges();
                    }
                    var put1 = _dbcontext.SELLER_db.Find(details.SELLER_ID);
                    if (put1 != null)
                    {
                        put1.EMAIL_ID = details.EMAIL_ID;
                        put1.GENDER = details.GENDER;
                        _dbcontext.SaveChanges();
                    }
                    transfer.Commit();
                }
                catch (Exception ex)
                {
                    transfer.Rollback();
                }
            }
            return details;
        }
        public async Task<object> DELETE(int id)
        {
            using (var transaction = _dbcontext.Database.BeginTransaction())
            {
                try
                {
                    var put = _dbcontext.SELLER_db.Find(id);
                    if (put != null)
                    {
                        _dbcontext.Remove(put);
                        _dbcontext.SaveChanges();

                    }
                    var put1 = _dbcontext.customer_db.Find(id);
                    if (put1 != null)
                    {

                        _dbcontext.Remove(put1);
                        _dbcontext.SaveChanges();

                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {

                    transaction.Rollback();
                }
            }
            return id;
        }
    }
}
       