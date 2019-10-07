﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_19k.Domain;
using App_19k.Repository.Context;

namespace App_19k.Repository.Implementacion
{
    public class AdministradorRepository : IAdministradorRepository
    {
        private ApplicationDbContext context;

        public AdministradorRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public Administrador Get(int id)
        {
            var result = new Administrador();
            try
            {
                result = context.Administradores.Single(x => x.AdministradorId == id);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<Administrador> GetAll()
        {

            var result = new List<Administrador>();
            try
            {
                result = context.Administradores.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Administrador entity)
        {
            try
            {
                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }

        public bool Update(Administrador entity)
        {
            try
            {
                var AdministradorOriginal = context.Administradores.Single(
                    x => x.AdministradorId == entity.AdministradorId
                );

                AdministradorOriginal.AdministradorId = entity.AdministradorId;
                AdministradorOriginal.AdministradorNavigation.NUsuario = entity.AdministradorNavigation.NUsuario;          

                context.Update(AdministradorOriginal);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}