using AutoMapper;
using DNC.DAL.Database;
using DNC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DNC.DAL.Repository
{
    public class ToDoListRepository : IToDoListRepository
    {
        private readonly DatabaseContext _dataConext;
        public ToDoListRepository()
        {
            _dataConext = new DatabaseContext();
        }
        public bool AddList(ToDoListModel todo)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ToDoListModel, ToDoList>());
            var mapper = new Mapper(config);
            ToDoList list = mapper.Map<ToDoList>(todo);

            _dataConext.ToDoLists.Add(list);
            return _dataConext.SaveChanges() > 0 ? true : false;
        }

        public bool DeleteList(long id)
        {
            var list = _dataConext.ToDoLists.FirstOrDefault(x => x.ID == id);
            _dataConext.ToDoLists.Remove(list);
            return _dataConext.SaveChanges() > 0 ? true : false;
        }

        public List<ToDoListModel> GetAllToDoList()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ToDoList, ToDoListModel>());
            var mapper = new Mapper(config);
            List<ToDoListModel> list = new List<ToDoListModel>();

            var entities = _dataConext.ToDoLists.ToList();
            foreach (var item in entities)
            {
                ToDoListModel emp = mapper.Map<ToDoListModel>(item);
                list.Add(emp);
            }
            return list;
        }

        public ToDoListModel GetListById(long id)
        {
            var ent = _dataConext.ToDoLists.FirstOrDefault(x => x.ID == id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ToDoList, ToDoListModel>());
            var mapper = new Mapper(config);
            ToDoListModel emp = mapper.Map<ToDoListModel>(ent);
            return emp;
        }

        public bool UpdateList(ToDoListModel todo)
        {
            var ent = _dataConext.ToDoLists.FirstOrDefault(x => x.ID == todo.ID);


            var config = new MapperConfiguration(cfg => cfg.CreateMap<ToDoListModel, ToDoList>());
            var mapper = new Mapper(config);
            ToDoList emp = mapper.Map<ToDoList>(todo);


            ent.Name = emp.Name;
            ent.IsCompleted = emp.IsCompleted;
           

            return _dataConext.SaveChanges() > 0 ? true : false;
        }
    }
}
