using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace FirstMVCApp.Services
{
    public class Processor
    {
        readonly IDbAccess dbAccess;

        public Processor(IDbAccess dbAccess)
        {
            this.dbAccess = dbAccess;
        }

        public void Process(int a, int b)
        {
            //calculate stuff
            int result = a + b * 2;

            dbAccess.Save(result);
        }
    }

    public interface IDbAccess
    {
        void Save(int input);
    }

    public class DbAccess : IDbAccess
    {
        public void Save(int input)
        {
            throw new Exception("This is fail");
            //returnh nothing;
        }
    }
}
