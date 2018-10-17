using Dapper;
using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using DDD.Domain.ValueObjects;
using DDD.Infra.Context;
using System;
using System.Linq;
//string sql = " SELECT [ID]			 " +
//                          "       ,[Name]			 " +
//                          "       ,[BirthDay]		 " +
//                          "       ,[Document]		 " +
//                          "       ,[Password]		 " +
//                          "       ,[Address]		 " +
//                          "       ,[CreatedAt]	 " +
//                          "       ,[ModifiedAt]	 " +
//                          "       ,[UserModified]	 " +
//                          "       ,[email]		 " +
//                          "   FROM [User]    ";

namespace DDD.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private IDB DB;
        public UserRepository(IDB db)
        {
            DB = db;
        }
        public bool DocumentExists(Document document)
        {
            using (var con = DB.GetCon())
            {
                string sql = " SELECT [Document] FROM [User] WHERE Document = @Document ";
                int c = con.Query<User>(sql, new { Document = document }).Count();

                return c > 0 ? true : false;
            }
        }

        public bool EmailExist(string email)
        {
            using (var con = DB.GetCon())
            {
                string sql = " SELECT [Email] FROM [User] WHERE Email = @Email ";
                int c = con.Query<User>(sql, new { Email = email }).Count();

                return c > 0 ? true : false;
            }
        }

        public void Save(User user)
        {
            using (var con = DB.GetCon())
            {
                string sql = $" INSERT INTO [USER]  " +
                            $"   ([ID]             "+
                            $"   ,[Name]           "+
                            $"   ,[BirthDay]       "+
                            $"   ,[Document]       "+
                            $"   ,[Password]       "+
                            $"   ,[Address]        "+
                            $"   ,[CreatedAt]      "+
                            $"   ,[UserModified]   "+
                            $"   ,[email])         "+
                            "  VALUES " +
                            "       (@ID		 " +
                            "       ,@Name	 " +
                            "       ,@BirthDay " +
                            "       ,@Document " +
                            "       ,@Password	 " +
                            "       ,@Address  " +
                            "       ,@CreatedAt	 " +
                            "       ,@UserModified " +
                            "       ,@email)		 ";

                 con.Execute(sql, new {
                    ID = user.ID,
                    Name=user.Name,
                    BirthDay=user.BirthDay,
                    Document=user.CPF.Number,
                    Password=user.Password,
                    Address=user.Address,
                    CreatedAt=user.CreatedAt,
                    UserModified=Guid.NewGuid(),
                    email=user.Email
                });
            }
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
