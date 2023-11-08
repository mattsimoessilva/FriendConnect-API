using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace APITutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendController : ControllerBase
    {
        private List<Friend> friends = new List<Friend>();

        public FriendController()
        {
            friends.Add(new Friend(1, "Kindson", "Munonye", "Budapest", DateTime.Today));
            friends.Add(new Friend(2, "Oleander", "Yuba", "Nigeria", DateTime.Today));
            friends.Add(new Friend(3, "Saffron", "Lawrence", "Lagos", DateTime.Today));
            friends.Add(new Friend(4, "Jadon", "Munonye", "Asaba", DateTime.Today));
        }

        // GET: api/Friend
        [HttpGet]
        public List<Friend> Get()
        {
            return friends;
        }

        // GET api/Friend/5
        [HttpGet("{id}", Name = "Get")]
        public Friend Get(int id)
        {
            Friend friend = friends.Find(f => f.id == id);
            return friend;
        }

        // POST api/Friend
        [HttpPost]
        public List<Friend> Post([FromBody] Friend friend)
        {
            friends.Add(friend);
            return friends;
        }

        // PUT api/Friend/5
        [HttpPut("{id}")]
        public List<Friend> Put(int id, [FromBody] Friend friend)
        {
            Friend friendToUpdate = friends.Find(f => f.id == id);
            int index = friends.IndexOf(friendToUpdate);

            friends[index].firstname = friend.firstname;
            friends[index].lastname = friend.lastname;
            friends[index].location = friend.location;
            friends[index].dateOfHire = friend.dateOfHire;

            return friends;
        }
        

        // DELETE api/ApiWithActions/5
        [HttpDelete("{id}")]
        public List<Friend> Delete(int id)
        {
            Friend friend = friends.Find(f => f.id == id);
            friends.Remove(friend);
            return friends;
        }
    }
}
