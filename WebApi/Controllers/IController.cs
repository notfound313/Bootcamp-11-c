using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public interface IController<T>
{
	IActionResult GetAll();
	IActionResult GetById(int id);
	IActionResult Add(T entity);
	IActionResult Update(int id, T entity);
	IActionResult Delete(int id);
}
