using AutoMapper;
using DTO;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WonderfulLibrary.Application.Query;
using WonderfulLibrary.UI.Models;

namespace WonderfulLibrary.UI.Controllers
{
    public class BookController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        #region constructor
        public BookController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        #endregion



        // GET: BookController
        public ActionResult Index()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Book, BookViewModel>());
            var query = _mediator.Send(new GetBooksQuery());

            var books = _mapper.Map<List<BookViewModel>>(query.Result);

            //BookViewModelValidator validationRules = new BookViewModelValidator();
            //var result = validationRules.Validate(books);

            return View(books);
        }

        // GET: BookController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BookController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
