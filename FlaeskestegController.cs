using Microsoft.AspNetCore.Mvc;

namespace serverdemo;

public class FlaeskestegController : ControllerBase
{
    [HttpGet(nameof(GetFlaeskestegs))]
    public List<Flaeskesteg> GetFlaeskestegs()
    {
        return FlaeskestegsDb.Flaeskestegs;
    }

    [HttpPost(nameof(CreateFlaeskesteg))]
    public void CreateFlaeskesteg([FromQuery]string sproedhed)
    {
        FlaeskestegsDb.Flaeskestegs.Add(new Flaeskesteg()
        {
            Sproedhed = Int32.Parse(sproedhed),
            SmagerGodt = true
        });
    }
    
    //Update by ID
    [HttpPatch(nameof(UpdateFlaeskesteg))]
    public void UpdateFlaeskesteg(int id)
    {
        //Update the flaeasskawteafstefg
    }
    
    
    //Delete by ID
    [HttpDelete(nameof(DeleteFlaeskesteg))]
    public void DeleteFlaeskesteg(int id)
    {
        //Go to the db and delete by ID
    }
    
    
}