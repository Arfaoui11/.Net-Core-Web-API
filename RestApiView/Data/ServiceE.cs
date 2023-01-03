using Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace RestApiView.Data
{
    public class ServiceE : ComponentBase
    {

        [Inject]
        HttpClient Http { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected List<Entreprise> entrepriseList = new();

       
        protected override async Task OnInitializedAsync()
        {
            await GetEntreprise();
        }

        protected async Task GetEntreprise()
        {
            entrepriseList = await Http.GetFromJsonAsync<List<Entreprise>>("api/Entreprise");
            
        }

       

        protected async Task DeleteEntreprise(int EntreID)
        {
            await Http.DeleteAsync("api/Entreprise/delete/" + EntreID);
            await GetEntreprise();
        }


     

        

        [Parameter]
        public int EntreID { get; set; }

        protected string Title = "Add";
        public Entreprise entreprise = new();
      

        protected override async Task OnParametersSetAsync()
        {
            if (EntreID != 0)
            {
                Title = "Edit";
                entreprise = await Http.GetFromJsonAsync<Entreprise>("api/Entreprise/" + EntreID);
            }
        }


        protected async Task SaveEntreprise()
        {
            if (entreprise.EntrepriseId != 0)
            {
                await Http.PutAsJsonAsync("api/Entreprise/update", entreprise);
            }
            else
            {
                await Http.PostAsJsonAsync("api/Entreprise/create", entreprise);
            }
            Cancel();
        }

        protected void DeleteConfirm(int entreID)
        {
            entreprise = entrepriseList.FirstOrDefault(x => x.EntrepriseId == entreID);
          //  Console.WriteLine(entreprise);
        }

        public void Cancel()
        {
            NavigationManager.NavigateTo("/entreprise");
        }

    }
}
