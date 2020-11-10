function BackendDockerCompose {
    docker-compose `
-f .\docker-compose.yml `
`
        -f .\ITLab-Back-Root\docker-compose.yml `
        -f .\ITLab-Back-Root\docker-compose.override.yml `
                -f .\ITLab-Back-Root\ITLab-Identity\docker-compose.yml `
                -f .\ITLab-Back-Root\ITLab-Identity\docker-compose.override.yml `
`
-f .\docker-compose.override.yml `
        $args
}

Set-Alias -Name idc BackendDockerCompose
