using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("api/[controller]")]
public class SentimentController : ControllerBase
{
    private readonly SentimentService _sentimentService;
    public SentimentController(SentimentService sentimentService)
    {
        _sentimentService = sentimentService;
    }
    [HttpPost]
    public ActionResult<SentimentPrediction> Predict([FromBody]
string text)
    {
        var prediction = _sentimentService.Predict(text);
        return Ok(prediction);
    }
}