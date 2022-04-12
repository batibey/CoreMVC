using CoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreMVC.ViewComponents
{
    public class CommentsList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    UserName = "Mustafa"
                },
                new UserComment {
                    ID = 2,
                    UserName = "Anıl"
                },
                new UserComment
                {
                    ID=3,
                    UserName = "Oguzhan"
                }
            };
            return View(commentValues);  
        }
    }
}
