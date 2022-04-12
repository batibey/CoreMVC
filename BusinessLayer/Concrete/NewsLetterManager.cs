using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class NewsLetterManager:INewsLetterService
    {
        INewsLetterDal _newsLetterDal;

        public NewsLetterManager(INewsLetterDal newsLetter)
        {
            _newsLetterDal = newsLetter;
        }

        public void AddNewsLetter(NewsLetter newsLetter)
        {
            _newsLetterDal.Insert(newsLetter);
        }
    }
}
