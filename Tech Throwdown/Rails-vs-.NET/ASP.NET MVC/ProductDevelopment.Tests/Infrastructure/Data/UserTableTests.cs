﻿using System.Linq;
using NUnit.Framework;
using ProductDevelopment.Web.Infrastructure.Data;
using ProductDevelopment.Web.Models;

namespace ProductDevelopment.Tests.Infrastructure.Data
{
    [TestFixture]
    public class UserTableTests
    {
        private ProductDevelopmentContext ctx;

        [TestFixtureSetUp]
        public void Setup()
        {
            ctx = new ProductDevelopmentContext();
        }

        private User CreateUser()
        {
            var user = new User();
            user.Username = "TestUser123";
            user.Password = "TestPassword123";
            user.Admin = false;
            ctx.Users.Add(user);
            ctx.SaveChanges();
            return user;
        }

        [Test]
        public void CreateUser_ShouldReturnUser()
        {
            var user = CreateUser();
            Assert.IsTrue(user.UserId > 0);
        }

        [Test]
        public void DeleteUser_UserShouldBeDeletedFromDatabase()
        {
            var user = CreateUser();
            ctx.Users.Remove(user);
            ctx.SaveChanges();
            var newUser = ctx.Users.Where(u => u.UserId == user.UserId).SingleOrDefault();
            Assert.IsNull(newUser);
        }

        [Test]
        public void EditUser_UserShouldBeEdited()
        {
            var user = CreateUser();
            user.Username = "AAAA";
            ctx.SaveChanges();
            var newUser = ctx.Users.Where(u => u.UserId == user.UserId).SingleOrDefault();
            Assert.AreEqual(newUser.Username, "AAAA");
        }
    }
}