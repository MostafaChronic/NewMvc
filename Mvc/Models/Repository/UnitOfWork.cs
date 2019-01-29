using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mvc.Models.Entity;

namespace Mvc.Models.Repository
{
    public class UnitOfWork : IDisposable
    {
        Contextes db = new Contextes();

        private AllRepositoies<Account> AccountRp;

        public AllRepositoies<Account> AccountsRp
        {
            get
            {
                if (AccountRp == null)
                {
                    AccountRp = new AllRepositoies<Account>(db);
                }

                return AccountRp;
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}