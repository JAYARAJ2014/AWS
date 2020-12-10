dotnet lambda deploy-function DotnetCalculator

CalcTest



{
  "Records": [
    {
      "s3": {
        "object": {
          "key": "numbers.txt"
        },
        "bucket": {
          "name": "calculator-input-<your_initials>"
        }
      }
    }
  ]
}