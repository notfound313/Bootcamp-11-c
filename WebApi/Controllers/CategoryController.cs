using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Repository;

namespace WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase, IController<Category>
{
	private readonly Database _db;
	public CategoryController(Database db)
	{
		_db = db;
	}

	[HttpPost]
	public IActionResult Add(Category entity)
	{
		_db.Categories.Add(entity);
		_db.SaveChanges();
		return Ok();
		
	}
	[HttpDelete]
	[Route("{id}")]
	public IActionResult Delete(int id)
	{
		Category category = _db.Categories.Find(id);
		if(category == null)
		{
			return NotFound();
		}
		_db.Categories.Remove(category);
		_db.SaveChanges();
		return Ok();
	}


	[HttpGet]
	public IActionResult GetAll()
	{
		List<Category> categories = _db.Categories.ToList();
		return Ok(categories);
	}

	[HttpGet]
	[Route("{id}")]
	public IActionResult GetById(int id)
	{
		Category? category = _db.Categories.Find(id);
		if(category == null)
		{
			return NotFound();
		}
		return Ok(category);
	}

	[HttpPut]
	[Route("{id}")]
	public IActionResult Update(int id, Category entity)
	{
		Category? category = _db.Categories.Find(id);
		if(category == null)
		{
			return NotFound();
		}
		category.CategoryName = entity.CategoryName;
		_db.SaveChanges();
		return Ok();
	}

}