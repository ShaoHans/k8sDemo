实验目标：利用k8s自带的服务发现功能访问其他api服务
步骤：
1.创建两个web api项目，分别为 K8S.Service.AppOne 和 K8S.Service.AppTwo，在AppOne项目中通过 http://k8s-service-apptwo 服务名称地址访问AppTwo项目提供的接口。
2.分别构建两个项目的镜像，并上传到docker hub
3.再分别编写两个项目的k8s yaml文件，然后通过kubectl apply命令部署
