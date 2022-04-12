﻿using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class WriterManager:IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetWriterById(int id)
        {
            return _writerDal.GetListAll(x => x.WriterId == id);
        }

        public void TAdd(Writer t)
        {
            _writerDal.Insert(t);
        }

        public void TDelete(Writer t)
        {
            throw new NotImplementedException();
        }

        public Writer TGetByID(int id)
        {
            return _writerDal.GetByID(1); 
        }

        public void TUpdate(Writer t)
        {
            _writerDal.Update(t);
        }

        
    }
}