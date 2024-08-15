using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.DTO;
using WebApi.Models;
using WebApi.Repository;

namespace WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase, IController<CategoryDTO>
{
	private readonly Database _db;
	private readonly IMapper _mapper;
	public CategoryController(Database db, IMapper mapper)
	{
		_db = db;
		_mapper = mapper;
		
	}

	[HttpPost]
	public IActionResult Add(CategoryDTO entity)
	{
		Category category = _mapper.Map<Category>(entity);
		_db.Categories.Add(category);
		_db.SaveChanges();
		return Ok("Successfully added");
		
	}
	[HttpDelete]
	[Route("{id}")]
	public IActionResult Delete(int id)
	{
		Category? category = _db.Categories.Find(id);
		if(category == null)
		{
			return NotFound();
		}
		_db.Categories.Remove(category);
		_db.SaveChanges();
		return Ok("Successfully deleted");
	}


	[HttpGet]
	public IActionResult GetAll()
	{
		List<CategoryDTO> categories = _mapper.Map<List<CategoryDTO>>(_db.Categories.ToList());
		return Ok(categories);
	}

	[HttpGet]
	[Route("{id}")]
	public IActionResult GetById(int id)
	{
		CategoryDTO? category = _mapper.Map<CategoryDTO>(_db.Categories.Find(id));
		if(category == null)
		{
			return NotFound();
		}
		return Ok(category);
	}

	[HttpPut]
	[Route("{id}")]
	public IActionResult Update(int id, CategoryDTO entity)
	{
		Category? category = _db.Categories.Find(id);
		if(category == null)
		{
			return NotFound();
		}
		category.CategoryName = entity.CategoryName;
		category.Description = entity.Description;	
		_db.SaveChanges();
		return Ok("Successfully updated");
	}

}