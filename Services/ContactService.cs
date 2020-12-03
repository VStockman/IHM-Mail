using Microsoft.EntityFrameworkCore;
using Models;
using Provider.EntityFramework;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    public class ContactService
    {
        private readonly Context context;

        public ContactService(Context context)
        {
            this.context = context;
        }

        public async Task<Contact> GetContactById(int id)
        {
            return await context.Contact.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<Contact> GetContactByEmail(string email)
        {
            return await context.Contact.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<List<Contact>> ContactListByCampaign(int campagneId)
        {
            return (await context.Contact.Where(c => c.CampaignId == campagneId).ToListAsync());
        }

        public async Task AddEmails(Campaign campagne, List<string> emailsList)
        {
            emailsList.ForEach(e =>
            {
                if (!string.IsNullOrEmpty(e))
                {
                    var newContact = new Contact
                    {
                        Email = e,
                        CampaignId = campagne.Id
                    };
                    context.Contact.Add(newContact);
                }
            });
            await context.SaveChangesAsync();
        }

        public async Task AddEmail(Contact contact)
        {
            context.Contact.Add(contact);
            await context.SaveChangesAsync();
        }

        public async Task UpdateContact(string newEmail, string oldEmail)
        {
            var contact = await GetContactByEmail(oldEmail);
            contact.Email = newEmail;
            await context.SaveChangesAsync();
        }

        public async Task DeleteContactByEmail(string email)
        {
            var contact = await GetContactByEmail(email);
            context.Contact.Remove(contact);
            await context.SaveChangesAsync();
        }

        public async Task DeleteContact(Contact dContact)
        {
            var contact = await GetContactById(dContact.Id);
            context.Contact.Remove(contact);
            await context.SaveChangesAsync();
        }

        public async Task DeleteDuplicate(Campaign campagne)
        {
            var contacts = await ContactListByCampaign(campagne.Id);
            
            foreach (var c in contacts)
            {
                var SameEmailList = context.Contact.Where(cc => cc.Email == c.Email).ToList();
                if (SameEmailList.Count != 1)
                {
                    await DeleteContact(c);
                }
            }
        }
    }
}
