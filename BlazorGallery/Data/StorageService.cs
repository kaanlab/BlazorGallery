using BlazorGallery.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace BlazorGallery.Data
{
    public class StorageService : DbContext
    {
        public StorageService(DbContextOptions<StorageService> options)
            : base(options)
        {
        }

        #region Pictures
        public DbSet<Picture> Pictures { get; set; }

        public IQueryable<Picture> GetPictures() => this.Pictures.AsQueryable();

        public async Task<Picture> AddPicture(Picture picture)
        {
            var pictureEntry = await this.Pictures.AddAsync(picture);
            await this.SaveChangesAsync();
            return pictureEntry.Entity;
        }

        public async Task<Picture> UpdatePicture(Picture picture)
        {
            var pictureToUpdate = await this.Pictures.FirstOrDefaultAsync(o => o.Id == picture.Id);
            pictureToUpdate.Author = picture.Author;
            pictureToUpdate.Text = picture.Text;
            pictureToUpdate.ImageUrl = picture.ImageUrl;
            pictureToUpdate.EmbededCode = picture.EmbededCode;
            var pictureEntry = this.Pictures.Update(pictureToUpdate);
            await this.SaveChangesAsync();
            return pictureEntry.Entity;
        }

        public async Task<Picture> DeletePicture(Picture picture)
        {
            var pictureToDelete = await this.Pictures.FirstOrDefaultAsync(o => o.Id == picture.Id);
            var pictureEntry = this.Pictures.Remove(pictureToDelete);
            await this.SaveChangesAsync();
            return pictureEntry.Entity;
        }
        #endregion

        #region Intros
        public DbSet<Intro> Intros { get; set; }

        public IQueryable<Intro> GetIntros() => this.Intros.AsQueryable();

        public Intro GetFirstIntro() => this.Intros.FirstOrDefault();

        public async Task<Intro> AddIntro(Intro intro)
        {
            var introEntry = await this.Intros.AddAsync(intro);
            await this.SaveChangesAsync();
            return introEntry.Entity;
        }

        public async Task<Intro> UpdateIntro(Intro intro)
        {
            var introToUpdate = await this.Intros.FirstOrDefaultAsync(o => o.Id == intro.Id);
            introToUpdate.EmbededCode = intro.EmbededCode;
            introToUpdate.MainText = intro.MainText;
            introToUpdate.BodyText = intro.BodyText;
            var introEntry = this.Intros.Update(introToUpdate);
            await this.SaveChangesAsync();
            return introEntry.Entity;
        }

        public async Task<Intro> DeleteIntro(Intro intro)
        {
            var introToDelete = await this.Intros.FirstOrDefaultAsync(o => o.Id == intro.Id);
            var introEntry = this.Intros.Remove(introToDelete);
            await this.SaveChangesAsync();
            return introEntry.Entity;
        }
        #endregion
    }
}
