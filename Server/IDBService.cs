﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Server.Models;
using System.Data;

namespace Server
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "IDBService" nel codice e nel file di configurazione contemporaneamente.
    [ServiceContract]
    public interface IDBService
    {
        [OperationContract]
        void Connessione();


        [OperationContract]
        bool Login(string email, string psw, bool organizzatore);

        [OperationContract]
        UtenteS InfoUtente(string e, string psw);

        [OperationContract]
        Ceo_organizzazioniS InfoCeo(string e, string psw);

        [OperationContract]
        string GetNomiOrganizzazioni();

        [OperationContract]
        bool Registrazione(string nome, string cognome, string username, string email, string password, bool isOrganizzatore, string nomeOrg);

        [OperationContract]
        List<EventoS> EventiDisponibili();

        [OperationContract]
        OrganizzazioneS GetOrganizzazioneFromId(int id);

        [OperationContract]
        BigliettoS GetBigliettoFromIdEvento(int id);

        [OperationContract]
        bool AcquistaBiglietto(int idBig, int idUtente, bool isPremium, int idEvento, int numBig, bool isCeo);

        [OperationContract]
        List<EventoS> EventiFromCeo(int codOrg);

        [OperationContract]
        List<UtenteS> UtentiAquirenti(int idEvento);

        [OperationContract]
        List<Ceo_organizzazioniS> CeoFromEvento(int idEvento);

        [OperationContract]
        bool AggiungiEvento(string nome, string genere, string luogo, string descrizione, int nPosti, int codOrg, int costo);

        [OperationContract]
        bool ModificaUtente(string nome, string cognome, string username, string email, int id);

        [OperationContract]
        bool ModificaCeo(string nome, string cognome, string email, int id);

    }
}
