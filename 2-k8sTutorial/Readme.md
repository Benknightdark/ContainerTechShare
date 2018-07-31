https://github.com/kubernetes/kops/issues/5033


https://medium.com/@fhitchen/adding-heapster-metrics-to-a-kubernetes-dashboard-on-arm-with-rbac-7758162c269f


https://k8smeetup.github.io/docs/tasks/run-application/horizontal-pod-autoscale-walkthrough/

az aks create --resource-group AKSRG --name demo-aks --node-count 3 --dns-name-prefix AKSRG --generate-ssh-keys --node-vm-size Standard_DS5_v2 --kubernetes-version 1.9.9 --no-wait


az network public-ip create -g MC_AKSRG_demo-aks_japaneast -n ben-public-ip --allocation-method static --dns-name ben-public-ip

az network public-ip show -g MC_AKSRG_demo-aks_japaneast -n ben-public-ip  --query "{fqdn: dnsSettings.fqdn, address: ipAddress}"
