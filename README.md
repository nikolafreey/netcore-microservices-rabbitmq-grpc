# netcore-microservices-rabbitmq-grpc
Building .NET Microservices with full architecture around them including API Gateway and deploying using Docker and Kubernetes. We also make use of both Sync and Async ways of communication between the microservices.For Sync communication we`ll utilize the standard REST API communication over HTTP/HTTPS but we`ll have a GRPC service aswell which presents a much faster way of communicating although it'll give us more trouble on initial implementation.

We'll have Platform and Commands services.

<ul>
  <li>Building two .NET Microservices using the REST API pattern</li>
  <li>Working with dedicated persistence layers for both services</li>
  <li>Deploying our services to Kubernetes cluster</li>
  <li>Employing the API Gateway pattern to route to our services</li>
  <li>Building Synchronous messaging between services (HTTP & gRPC)</li>
  <li>Building Asynchronous messaging between services using an Event Bus (RabbitMQ)</li>
</ul>
