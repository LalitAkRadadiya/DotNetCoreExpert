using DNC.DAL.Repository;
using DNC.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DNC.BAL.Manager
{
    public class ToDoListManager : IToDoListManager
    {
        private readonly IToDoListRepository _dbRepositpory;

        public ToDoListManager(IToDoListRepository dbRepository)
        {
            _dbRepositpory = dbRepository;
        }
        public bool AddList(ToDoListModel todo)
        {
            return _dbRepositpory.AddList(todo);
        }

        public bool DeleteList(long id)
        {
            return _dbRepositpory.DeleteList(id);
        }

        public List<ToDoListModel> GetAllToDoList()
        {
            return _dbRepositpory.GetAllToDoList();
        }

        public ToDoListModel GetListById(long id)
        {
            return _dbRepositpory.GetListById(id);
        }

        public bool UpdateList(ToDoListModel todo)
        {
            return _dbRepositpory.UpdateList(todo);
        }
    }
}
