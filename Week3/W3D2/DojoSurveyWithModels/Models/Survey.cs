
using System.ComponentModel.DataAnnotations;
namespace DojoSurveyWithModels;
public class Survey
{
    public string Name {get; set;} = null!;
    public string Location{get; set;}= null!;
    public string FavLanguage{get;set;}= null!;
    public string? Comment{get;set;}
}

