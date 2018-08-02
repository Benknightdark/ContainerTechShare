https://github.com/kubernetes/kops/issues/5033


https://medium.com/@fhitchen/adding-heapster-metrics-to-a-kubernetes-dashboard-on-arm-with-rbac-7758162c269f


https://k8smeetup.github.io/docs/tasks/run-application/horizontal-pod-autoscale-walkthrough/

az group create --name AKSRG --location japaneast

az aks create --resource-group AKSRG --name demo-aks --node-count 3 --dns-name-prefix AKSRG --generate-ssh-keys --node-vm-size Standard_DS5_v2 --kubernetes-version 1.10.5 --no-wait


az network public-ip create -g MC_AKSRG_demo-aks_japaneast -n ben-dev --allocation-method static --dns-name ben-dev
az network public-ip create -g MC_AKSRG_demo-aks_japaneast -n ben-pm --allocation-method static --dns-name ben-pm -o table
az network public-ip create -g MC_AKSRG_demo-aks_japaneast -n ben-prod --allocation-method static --dns-name ben-prod -o table
az network public-ip show -g MC_AKSRG_demo-aks_japaneast -n ben-dev  --query "{fqdn: dnsSettings.fqdn, address: ipAddress}"


docker build -t ikgacr.azurecr.io/docker-mvc:ben-dev --no-cache --build-arg ReleaseType=Development .
docker build -t ikgacr.azurecr.io/docker-mvc:ben-pm --no-cache --build-arg ReleaseType=pm .

docker build -t ikgacr.azurecr.io/docker-mvc:ben-prod --no-cache --build-arg ReleaseType=Production .

docker push ikgacr.azurecr.io/docker-mvc:ben-dev
docker push ikgacr.azurecr.io/docker-mvc:ben-pm
docker push ikgacr.azurecr.io/docker-mvc:ben-prod


helm install --name docker-mvc-dev ./docker-mvc-chart -f ./docker-mvc-chart/values.dev.yaml
helm install --name docker-mvc-prod ./docker-mvc-chart -f ./docker-mvc-chart/values.prod.yaml
helm install --name docker-mvc-pm ./docker-mvc-chart -f ./docker-mvc-chart/values.pm.yaml


helm del --purge   docker-mvc-dev
helm del --purge   docker-mvc-pm
helm del --purge   docker-mvc-prod

CLIENT_ID=$(az aks  show -g aksRG -n demo-aks  --query "servicePrincipalProfile.clientId" -o tsv)
ACR_ID=$(az acr show --name ikgAcr --resource-group iKG_Container --query "id" --output tsv)
az role assignment create --assignee $CLIENT_ID --role Reader --scope $ACR_ID
