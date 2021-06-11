function BackendDockerCompose {
    docker-compose `
-f .\docker-compose.yml `
`
        -f .\ITLab-Back-Root\docker-compose.yml `
        -f .\ITLab-Back-Root\docker-compose.override.yml `
                -f .\ITLab-Back-Root\ITLab-Identity\docker-compose.yml `
                -f .\ITLab-Back-Root\ITLab-Identity\docker-compose.override.yml `
                -f .\ITLab-Back-Root\ITLab-PushNotificationService\docker-compose.yml `
                -f .\ITLab-Back-Root\ITLab-PushNotificationService\docker-compose.override.yml `
                -f .\ITLab-Back-Root\ITLab-Notify\docker-compose.yml `
                -f .\ITLab-Back-Root\ITLab-Notify\docker-compose.override.yml `
                -f .\ITLab-Back-Root\ITLab-Feedback\docker-compose.yml `
                -f .\ITLab-Back-Root\ITLab-Feedback\docker-compose.override.yml `
                -f .\ITLab-Back-Root\ITLab-Projects\docker-compose.yml `
                -f .\ITLab-Back-Root\ITLab-Projects\docker-compose.override.yml `
`
        -f .\ITLab-Front-Root\docker-compose.yml `
        -f .\ITLab-Front-Root\docker-compose.override.yml `
-f .\docker-compose.override.yml `
        $args
}

function ProductionBackendDockerCompose {
        docker-compose `
-f .\docker-compose.yml `
`
        -f .\ITLab-Back-Root\docker-compose.yml `
        -f .\ITLab-Back-Root\docker-compose.prod.yml `
                -f .\ITLab-Back-Root\ITLab-Identity\docker-compose.yml `
                -f .\ITLab-Back-Root\ITLab-Identity\docker-compose.prod.yml `
                -f .\ITLab-Back-Root\ITLab-PushNotificationService\docker-compose.yml `
                -f .\ITLab-Back-Root\ITLab-PushNotificationService\docker-compose.prod.yml `
                -f .\ITLab-Back-Root\ITLab-Notify\docker-compose.yml `
                -f .\ITLab-Back-Root\ITLab-Notify\docker-compose.prod.yml `
                -f .\ITLab-Back-Root\ITLab-Feedback\docker-compose.yml `
                -f .\ITLab-Back-Root\ITLab-Feedback\docker-compose.prod.yml `
                -f .\ITLab-Back-Root\ITLab-Projects\docker-compose.yml `
                -f .\ITLab-Back-Root\ITLab-Projects\docker-compose.prod.yml `
`
        -f .\ITLab-Front-Root\docker-compose.yml `
        -f .\ITLab-Front-Root\docker-compose.prod.yml `
`
-f .\docker-compose.prod.yml `
        $args
}

Set-Alias -Name idc BackendDockerCompose
Set-Alias -Name pidc ProductionBackendDockerCompose
