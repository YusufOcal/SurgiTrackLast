﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAnalAtreziDal : EfEntityRepositoryBase<AnalAtrezi, SurgiTrackContext>, IAnalAtreziDal
    {

        public void DeleteById(int id)
        {
            using (SurgiTrackContext context = new())
            {
                var deletedEntity = context.Entry(context.Set<AnalAtrezi>().Find(id));
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

    }
}
