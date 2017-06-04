#!/bin/sh

REPO=nubian
DIST=zesty

if ! which aptly >/dev/null 2>&1; then
  echo "Please install aptly"
  exit 1
fi

if ! which gpg >/dev/null 2>&1; then
  echo "Please install gnupg and gnupg-agent"
  exit 1
fi

if [ ! -d ~/.gnupg ]; then
  gpg --gen-key
fi

aptly repo create  -architectures="all" -component="main" -distribution="$DIST" $REPO-$DIST
aptly publish repo -architectures="all" $REPO-$DIST

