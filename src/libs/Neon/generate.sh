dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://neon.com/api_spec/release/v2.json
autosdk generate openapi.yaml \
  --namespace Neon \
  --clientClassName NeonClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
