using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
namespace WebApp.Controllers;

public class CategoryController : Controller
{
	private readonly DataContex _db;
	public CategoryController(DataContex db) 
	{
		_db = db;
	}
	public  IActionResult Index() 
	{
		List<Category> categories = _db.Categories.ToList();
		return View(categories);
	}
	public IActionResult Create()
	{
		return View();
	}
	[HttpPost]
	public IActionResult Create(Category category)
	{
		bool status = _db.Categories.Any(cat => cat.CategoryName == category.CategoryName);
		if(status) 
		{
			TempData["Error"] = "Category already exist";
			return RedirectToAction("Index");
		}
		_db.Categories.Add(category);
		_db.SaveChanges();
		return RedirectToAction("Index");
		
	}
	
	public IActionResult Update(int id)
	{
		Category category = _db.Categories.Find(id);
		return View(category);
	}
	[HttpPost]
	public IActionResult Update(Category category)
	{
		_db.Categories.Update(category);
		_db.SaveChanges();
		return RedirectToAction("Index");
	}
	
	public IActionResult Delete(int id) 
	{
		Category category = _db.Categories.Find(id);
		return View(category);
	}
	
	[HttpPost]
	public IActionResult Delete(Category category)
	{
		_db.Categories.Remove(category);
		_db.SaveChanges();
		return RedirectToAction("Index");
	}
}
