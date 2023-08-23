# Security API

API to access local Motion livestream from internet.
As my ISP cannot guarantee to have a fixed IP address, this API allows to register the current IP using an HTTP call to then be able to access the Motion livestream from anywhere in the world.

## API endpoints

The available endpoints are:

- `GET /register`: updates the current IP address
- `GET /ip`: returns the stored IP address
- `GET /live`: redirects to the Motion livestream


## The setup

Motion is setup on a Raspberry Pi Zero with a single camera and records every movement to a local cloud server. A crontab is configured to call the `/register` endpoint every 2 minutes. This allows to keep the free Azure Web instance always running and also make sure that any IP address change will be picked up quickly.

