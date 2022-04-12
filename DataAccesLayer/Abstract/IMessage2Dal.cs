using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccesLayer.Abstract
{
    public interface IMessage2Dal: IGenericDal<Message2>
    {
        List<Message2> GetInboxWithMessageByWriter(int id);
        List<Message2> GetSendboxWithMessageByWriter(int id);
    }
}
