﻿using ApiProject.EntityFrameworkCore;
using ApiProject.Entitys;
using ApiProject.Query;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork;

namespace ApiProject.MyApi
{
    public class MyApiAppService : IMyApiAppService
    {
        private readonly IUnitOfWork unitOfWork;

        public MyApiAppService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> asdasda()
        {
            var data = unitOfWork.FromSql("SELECT Name FROM ProcessDb.dbo.AbpTenants");
            IQueryable<DemoProductCategorys> users = unitOfWork.GetRepository<DemoProductCategorys>().GetAll();
            unitOfWork.GetRepository<DemoProductCategorys>().Insert(new DemoProductCategorys { Name = "cmn", Active = true });
            unitOfWork.SaveChanges();
            throw new Exception();
            return new OkObjectResult(users.ToList());
        }
    }
}
