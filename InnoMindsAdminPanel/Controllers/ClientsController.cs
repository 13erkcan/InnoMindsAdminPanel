using InnoMindsAdminPanel.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace InnoMindsAdminPanel.Controllers
{
    public class ClientsController : Controller
    {
        // This would typically be stored in a database
        private static List<Client> _clients = new List<Client>
        {
            new Client { ClientId = 1, Name = "Berk Can", Email = "berkcann@mail.com", PhoneNumber = "0531-831-3379" },
            new Client { ClientId = 2, Name = "Paola Zandonatto", Email = "zandonatto@mail.com", PhoneNumber = "0532-158-5221" }
        };

        public IActionResult Index()
        {
            return View(_clients);
        }

        public IActionResult Details(int id)
        {
            var client = _clients.FirstOrDefault(c => c.ClientId == id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }

        public IActionResult Edit(int id)
        {
            var client = _clients.FirstOrDefault(c => c.ClientId == id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }

        [HttpPost]
        public IActionResult Edit(int id, Client clientToUpdate)
        {
            var client = _clients.FirstOrDefault(c => c.ClientId == id);
            if (client != null && ModelState.IsValid)
            {
                client.Name = clientToUpdate.Name;
                client.Email = clientToUpdate.Email;
                client.PhoneNumber = clientToUpdate.PhoneNumber;
                // Here you would typically save these changes to the database
                return RedirectToAction(nameof(Index));
            }
            return View(clientToUpdate);
        }

        public IActionResult Delete(int id)
        {
            var client = _clients.FirstOrDefault(c => c.ClientId == id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var client = _clients.FirstOrDefault(c => c.ClientId == id);
            if (client != null)
            {
                _clients.Remove(client);
                // Here you would typically delete the client from the database
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
