using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("v1/")]
    public class ZXOpenAPIController : Controller
    {
        private readonly ILogger<ZXOpenAPIController> _logger;

        public ZXOpenAPIController(ILogger<ZXOpenAPIController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("blocks")]
        public List<Blocks> GetBlocks()
        {
            List<Blocks> blocks = new();
            blocks.Add(new Blocks
            {
                BlockNumber = 24392707,
                Status = "Finalized",
                Validator = "zx97u1ZvZrM1vert78AC1chww6yBzK35zqixQstxFBqmCFw",
            });
            blocks.Add(new Blocks
            {
                BlockNumber = 24392706,
                Status = "Finalized",
                Validator = "zx97u1ZvZrM1vert78AC1chww6yBzK35zqixQstxFBqmCFw",
            });
            blocks.Add(new Blocks
            {
                BlockNumber = 24392705,
                Status = "Finalized",
                Validator = "zx97u1ZvZrM1vert78AC1chww6yBzK35zqixQstxFBqmCFw",
            });
            blocks.Add(new Blocks
            {
                BlockNumber = 24392704,
                Status = "Finalized",
                Validator = "zx97u1ZvZrM1vert78AC1chww6yBzK35zqixQstxFBqmCFw",
            });
            blocks.Add(new Blocks
            {
                BlockNumber = 24392703,
                Status = "Finalized",
                Validator = "zx97u1ZvZrM1vert78AC1chww6yBzK35zqixQstxFBqmCFw",
            });
            return blocks;
        }

        [HttpGet]
        [Route("transfers")]
        public List<Transfers> GetTransfers()
        {
            List<Transfers> transfers = new();
            transfers.Add(new Transfers
            {
                Extrinsic = "24393685-3",
                BlockNumber = 24392707,
                Nonce = 13,
                Signature = "0xa871c47a7f48a12b38a994e48a9659fab5d6376f3dbce37559bcb617efe8662d",
                From = "zx9834876dcfb05cb167a5c24953eba58c4ac89b1adf57f28f2f9d09af107ee8f0",
                To = "zx3e744b9dc39389baf0c5a0660589b8402f3dbb49b89b3e75f2c9355852a3c677",
                For = 23.18,
            });
            transfers.Add(new Transfers
            {
                Extrinsic = "24393685-3",
                BlockNumber = 24392707,
                Nonce = 13,
                Signature = "0x12b0f0dcaefb10c02a83aa9adb025978ddb5512dc04eb39df6811c6a6bf9770c",
                From = "zxa95bc16631ae2b6fadb455ee018da0adc2703e56d89e3eed074ce56d2f7b1b6a",
                To = "zxf2afd1cacb5441a5e65a7a460a5f9898b7b98b08aa6323a2e53c8b9a9686cd86",
                For = 14.17,
            });
            transfers.Add(new Transfers
            {
                Extrinsic = "24393698-2",
                BlockNumber = 24392707,
                Nonce = 13,
                Signature = "0x27cad5b4de3b312be439e049f4820be9f4f4623e82093c2cd021d07e0273e588",
                From = "zxf5557d4fcf727a981a3c315aca733eefa2996f7c7cdae1fa7e0de28522820bb0",
                To = "zx3daabcc85cfd07e409fd5bcd3f4431584b331712c133ceb6f9f1c8b11f6c653a",
                For = 73.42,
            });
            return transfers;
        }
    }
}
