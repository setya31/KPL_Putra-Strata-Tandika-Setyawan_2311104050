using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class MahasiswaController : ControllerBase
{
    private static List<Mahasiswa> data = new List<Mahasiswa>
    {
        new Mahasiswa { Nama = "Putra Strata Tandika Setyawan", Nim = "2311104050" },
        new Mahasiswa { Nama = "Zhafir Zaidan Avail", Nim = "2311104059" },
        new Mahasiswa { Nama = "Dhimas Tulus Ikhsan", Nim = "2311104060" }
    };

    [HttpGet]
    public ActionResult<IEnumerable<Mahasiswa>> Get() => data;

    [HttpGet("{index}")]
    public ActionResult<Mahasiswa> Get(int index) => data[index];

    [HttpPost]
    public ActionResult Post([FromBody] Mahasiswa m)
    {
        data.Add(m);
        return Ok();
    }

    [HttpDelete("{index}")]
    public ActionResult Delete(int index)
    {
        data.RemoveAt(index);
        return Ok();
    }
}