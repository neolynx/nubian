#!/bin/sh

REPO=nubian
DIST=zesty

if [ -z "$1" ]; then
  echo "Usage: $0 FILE..."
  echo "for files *.deb, *.dsc"
  exit 1
fi


aptly repo add $REPO-$DIST $@

aptly publish update -architectures="all" $DIST

