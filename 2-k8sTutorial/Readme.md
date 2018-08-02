https://github.com/kubernetes/kops/issues/5033


https://medium.com/@fhitchen/adding-heapster-metrics-to-a-kubernetes-dashboard-on-arm-with-rbac-7758162c269f


https://k8smeetup.github.io/docs/tasks/run-application/horizontal-pod-autoscale-walkthrough/

az group create --name AKSRG --location japaneast

az aks create --resource-group AKSRG --name demo-aks --node-count 3 --dns-name-prefix AKSRG --generate-ssh-keys --node-vm-size Standard_DS5_v2 --kubernetes-version 1.10.5 --no-wait


az network public-ip create -g MC_AKSRG_demo-aks_japaneast -n ben-dev --allocation-method static --dns-name ben-public-ip

az network public-ip show -g MC_AKSRG_demo-aks_japaneast -n ben-dev  --query "{fqdn: dnsSettings.fqdn, address: ipAddress}"

https://storage.googleapis.com/kubernetes-helm/helm-v2.9.1-linux-amd64.tar.gz
