using System;
using System.Collections.Generic;
using System.Linq;
using MitechCenter.vn.Models.Repository;
using Newtonsoft.Json;

namespace MitechCenter.vn.Models.DataManager
{
    public class StaticElementManager : IDataRepository<StaticElement>
    {
        readonly MitechCenterContext _context;
        public StaticElementManager(MitechCenterContext context)
        {
            _context = context;
        }

        public void Add(StaticElement entity)
        {
            _context.StaticElements.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(StaticElement entity)
        {
            _context.StaticElements.Remove(entity);
            _context.SaveChanges();
        }

        public StaticElement Get(long id)
        {
            return _context.StaticElements.FirstOrDefault(e => e.eId == id);
        }

        public StaticElement Get(string key)
        {
            return _context.StaticElements.FirstOrDefault(e => e.eKey == key);
        }

        public IEnumerable<StaticElement> GetAll()
        {
            return _context.StaticElements.ToList();
        }

        public void Update(StaticElement dbEntity, StaticElement entity)
        {
            Console.WriteLine(JsonConvert.SerializeObject(entity));
            dbEntity.DeepCopy(entity);
            _context.SaveChanges();
        }
    }
}