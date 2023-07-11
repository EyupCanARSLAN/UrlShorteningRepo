using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public class UrlShorteningRepository : IUrlShorteningRepository
    {
        UrlShorteningDbContext _urlShorteningDbContext;
        public UrlShorteningRepository(UrlShorteningDbContext urlShorteningDbContext)
        {
            _urlShorteningDbContext=urlShorteningDbContext;
        }
        public void CreateUrlShortening(UrlShortening urlShortening)
        {

            _urlShorteningDbContext.Add(urlShortening);
            _urlShorteningDbContext.SaveChanges();
            
        }
        public void DeleteByShorteningUrl(string shorteningUrl)
        {
            throw new NotImplementedException();
        }

        public void DeleteUrlShortening(string shorteningUrl)
        {
          
                var recordInDb= _urlShorteningDbContext.UrlShortening.FirstOrDefault(x => x.ShorteningUrl == shorteningUrl && !x.IsDeleted);
                if (recordInDb != null)
                {
                    recordInDb.IsDeleted = true;
                _urlShorteningDbContext.SaveChanges();
                }
                else
                {
                    throw new Exception($"The delete progress did not occered. There isnt any record for given url : {shorteningUrl} ");
                }
            
        }

     

        public UrlShortening? FindByOriginalUrl(string originalUrl)
        {
         
               return _urlShorteningDbContext.UrlShortening.FirstOrDefault(x=>x.OriginalUrl== originalUrl && !x.IsDeleted);
            
        }

        public UrlShortening? FindByShorteningUrl(string shorteningUrl)
        { 
                return _urlShorteningDbContext.UrlShortening.FirstOrDefault(x => x.ShorteningUrl == shorteningUrl && !x.IsDeleted);
            
        }
    }
}
