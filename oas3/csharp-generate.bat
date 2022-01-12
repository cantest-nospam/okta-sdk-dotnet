set executable=.\swagger-codegen-cli.jar

set ags=generate -i ./spec/management.json -l csharp -o generated -c ./config.json --additional-properties hideGenerationTimestamp=true

java %JAVA_OPTS% -jar %executable% %ags%
