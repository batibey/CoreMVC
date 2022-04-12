using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);
        List<Comment> GetCommentWithBlog();
        List<Comment> GetList(int id);

    }
}
