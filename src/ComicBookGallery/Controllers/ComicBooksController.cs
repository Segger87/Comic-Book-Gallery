using ComicBookGallery.Models;
using ComicBookGallery.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRespository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRespository();
        }

	    public ActionResult Index()
	    {
		    var comicBooks = _comicBookRepository.GetComicBooks();

		    return View(comicBooks);
	    }
        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook(id.Value);

            return View(comicBook);
        }
    }
}