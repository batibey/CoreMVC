using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using DataAccesLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccesLayer.EntityFramework
{
    public class EFCommentRepository : GenericRepository<Comment>, ICommentDal
    {
        public List<Comment> GetListWithBlog()
        {
            using (var c = new Context())
            {
                return c.Comments.Include(x => x.Blog).ToList();
            }
        }
    }
}
