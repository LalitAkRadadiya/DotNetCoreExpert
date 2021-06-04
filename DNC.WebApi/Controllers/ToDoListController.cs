using DNC.BAL.Manager;
using DNC.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DNC.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListController : ControllerBase
    {
        private readonly IToDoListManager _dbManager;
        public ToDoListController(IToDoListManager dbManager)
        {
            _dbManager = dbManager;
        }
        [Route("GetAllToDoList")]
        public IActionResult GetAllToDoList()
        {
            return Ok(_dbManager.GetAllToDoList());
        }
        [Route("GetListById/{id}")]
        [HttpGet]
        public IActionResult GetListById(int id)
        {
            var result = _dbManager.GetListById(id);
            return Ok(result);

        }

        [HttpPost]
        [Route("AddList")]
        public IActionResult AddList(ToDoListModel model)
        {
            var result = _dbManager.AddList(model);
            return Ok(result);
        }

        [HttpPut]
        [Route("UpdateList")]
        public IActionResult UpdateList(ToDoListModel model)
        {
            var result = _dbManager.UpdateList(model);
            return Ok(result);

        }

        [HttpDelete]
        [Route("DeleteList/{id}")]
        public IActionResult DeleteList(int id)
        {
            var result = _dbManager.DeleteList(id);

            return Ok();

        }

    }
}
