using DNC.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DNC.DAL.Repository
{
    public interface IToDoListRepository
    {
        List<ToDoListModel> GetAllToDoList();
        ToDoListModel GetListById(long id);
        bool AddList(ToDoListModel todo);
        bool UpdateList(ToDoListModel todo);
        bool DeleteList(long id);
    }
}
