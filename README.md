# athena-editor
This is a simple editor to execute queries using the aws s3 credentials

#### Contacts:

- Rodrigo Aleman

## Installation Guidelines

#### Prerequisites:
- Net Framework 4.6.

#### Dependencies:
athenadb-api

#### Installation Instructions:

Run the executable


## Known Issues 


## Deployment instructions


## Configuration:

Config.cs
athenaDatabase: schema name
athenaOutputBucket: S3 location of the output
timeSleep: miliseconds to notify the query status
accessKeyId: asw accessKeyId
secretKey: aws secretKey
region: region ("US_EAST_1"...)
queries: list of queries to run,
useQueryId: if run the queryExecutionId,
queryExecutionId: the query Execution Id