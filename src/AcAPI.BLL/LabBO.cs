﻿using AcAPI.DAO;
using AcAPI.DTL;

namespace AcAPI.BLL
{
    public class LabBO : ILab
    {
        private readonly ILabDAO _labDAO;

        public LabBO(ILabDAO labDAO)
        {
            _labDAO = labDAO;
        }

        public void Adicionar(LabDTO lab)
        {
            _labDAO.Incluir(lab);
        }

        public void Excluir(int id)
        {
            _labDAO.Excluir(id);
        }

        public List<LabDTO> Listar()
        {
            return _labDAO.Listar();
        }

        public void Atualizar(LabDTO lab)
        {
            _labDAO.Atualizar(lab);
        }
        public LabDTO SelecionarLab(int id)
        {
            return _labDAO.SelecionarLab(id);
        }
        void ILab.Ativar(int id)
        {
            _labDAO.Ativar(id);
        }
        void ILab.Inativar(int id)
        {
            _labDAO.Inativar(id);
        }
    }
}
