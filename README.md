# workshop-testing

Step to run
```
$docker-compose up
```

Open url=http://localhost:9000/api/values in web browser

Jenkins pipeline script
```
node {
   def mvnHome
   stage('PullCode') { 
      git 'git@github.com:up1/workshop-testing.git'
   }
   stage('Build') {
       sh label: '', script: '''dotnet restore
dotnet build'''
   }
   stage('Unit testing') {
      sh label: '', script: 'rm -rf Testing/TestResults'
      sh label: '', script: 'dotnet test --logger "trx;LogFileName=results\\unit_tests.xml"  --no-build --no-restore'
      xunit([MSTest(deleteOutputFiles: true, failIfNotNew: true, pattern: 'Testing\\TestResults\\results\\*.xml', skipNoTestFiles: false, stopProcessingIfError: true)])
   }
   stage ('Code coverage') {
      sh label: '', script: 'dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura --no-build --no-restore' 
      cobertura coberturaReportFile: '**/coverage.cobertura.xml'
   }
   stage('Deploy on Dev') {
      sh label: '', script: '''docker-compose build
docker-compose down
docker-compose up -d'''
   }
   stage('API testing') {
      sh label: '', script: 'newman run product.postman_collection.json'
   }
   stage('UI testing') {
      
   }
   stage('Shutdown api') {
    //   sh label: '', script: 'docker-compose down'
   }
}
```
