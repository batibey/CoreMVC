using DataAccesLayer.Abstract;
using DataAccesLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccesLayer.EntityFramework
{
    public class EFNotificationRepository : GenericRepository<Notification>, INotificationDal
    {

    }
}
