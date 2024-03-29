﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1P_Ap1_Darianna_2019_0261.Entidades;
using _1P_Ap1_Darianna_2019_0261.DAL;
using Microsoft.EntityFrameworkCore;

namespace _1P_Ap1_Darianna_2019_0261.BLL
{
    public class AportesBLL
    {

        private static bool Insertar(Aportes Aportes)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Aportes.Add(Aportes) != null)

                    paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            { throw; }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        private static bool Modificar(Aportes Aportes)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(Aportes).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            { throw; }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                Aportes Aportes = db.Aportes.Find(id);

                if (Existe(id))
                {
                    db.Aportes.Remove(Aportes);
                    paso = db.SaveChanges() > 0;
                }
            }
            catch (Exception)
            { throw; }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static Aportes Buscar(int id)
        {
            Contexto db = new Contexto();
            Aportes Aportes = new Aportes();
            try
            {
                Aportes = db.Aportes.Find(id);

            }
            catch (Exception)
            { throw; }
            finally
            {
                db.Dispose();
            }
            return Aportes;
        }

        public static List<Aportes> GetList(System.Linq.Expressions.Expression<Func<Aportes, bool>> expression)
        {
            List<Aportes> Aportes = new List<Aportes>();
            Contexto db = new Contexto();
            try
            {
                Aportes = db.Aportes.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Aportes;
        }

        private static bool Existe(int id)
        {
            bool encontrado = false;
            Contexto db = new Contexto();
            try
            {
                encontrado = db.Aportes.Any(x => x.AporteId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return encontrado;
        }

        public static bool Guardar(Aportes Aportes)
        {
            if (!Existe(Aportes.AporteId))
                return Insertar(Aportes);
            else
                return Modificar(Aportes);
        }
    }
}