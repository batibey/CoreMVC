using DataAccesLayer.Abstract;
using DataAccesLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccesLayer.EntityFramework
{
    public class EFAdminRepository:GenericRepository<Admin>,IAdminDal
    {
    }
}
