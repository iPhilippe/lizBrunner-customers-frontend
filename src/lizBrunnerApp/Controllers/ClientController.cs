using AutoMapper;
using LizBrunner.App.ViewModels;
using LizBrunner.Business.Interfaces;
using LizBrunner.Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace LizBrunner.App.Controllers
{

    public class ClientController : BaseController
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;


        public ClientController(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        // GET: Client
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<ClientViewModel>>(await _clientRepository.ObterQuinzeRegistros()));
        }

        // GET: Client/Details/5
        public async Task<IActionResult> Details(Guid id)
        {

            var clientViewModel = await ObterClientEEndereco(id);
            if (clientViewModel == null)
            {
                return NotFound();
            }

            return View(clientViewModel);
        }

        // GET: Client/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Client/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ClientViewModel clientViewModel)
        {
            if (!ModelState.IsValid) return View(clientViewModel);
            
            clientViewModel.RegisterDate = DateTime.Now; //Pega a data do registro no momento do cadastro 

           var client = _mapper.Map<Client>(clientViewModel);
            await _clientRepository.Adicionar(client);

            return RedirectToAction("Index");

        }

        // GET: Client/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {

            var clientViewModel = await ObterClientEEndereco(id);
            if (clientViewModel == null)
            {
                return NotFound();
            }

            return View(clientViewModel);
        }

        // POST: Client/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, ClientViewModel clientViewModel)
        {
            if (id != clientViewModel.Id) return NotFound();

            if (!ModelState.IsValid) return View(clientViewModel);

            var client = _mapper.Map<Client>(clientViewModel);
            await _clientRepository.Atualizar(client);

            return RedirectToAction("Index");
        }

        // GET: Client/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {

            var clientViewModel = await ObterClientEEndereco(id);

            if (clientViewModel == null) return NotFound();


            return View(clientViewModel);
        }

        // POST: Client/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var clientViewModel = await ObterClientEEndereco(id);

            if (clientViewModel == null) return NotFound();

            await _clientRepository.Remover(id);

            return RedirectToAction("Index");
        }


        private async Task<ClientViewModel> ObterClientEEndereco(Guid id)
        {
            return _mapper.Map<ClientViewModel>(await _clientRepository.ObterPorId(id));
        }

    }
}
